Imports System.Collections.Concurrent
Imports MineProducts.Events.Interfaces

Namespace Events
    Public Class EventAggregator
        Implements IEventAggregator

        Private Shared ReadOnly Property _eventAggregator As IEventAggregator = New EventAggregator()

        Public Shared Property PublishMessagesEnabled As Boolean = False

        Public Shared ReadOnly Property Events As IEventAggregator
            Get
                Return _eventAggregator
            End Get
        End Property

        Private ReadOnly Property subscriptions As ConcurrentDictionary(Of Type,List(Of Object)) = New ConcurrentDictionary(Of Type, List(Of Object))

        Public Sub Publish(Of T As IApplicationEvent)(message As T) Implements IEventAggregator.Publish
            Dim subscribers As New List(Of Object)
            If (subscriptions.TryGetValue(GetType(T), subscribers)) Then
                For Each subscriber As Action(Of T) In subscribers.ToArray()
                    subscriber(message)
                Next
            End If
        End Sub

        Public Sub Subscribe (Of T As IApplicationEvent)(action As Action(Of T)) Implements IEventAggregator.Subscribe
            Dim subscribers As List(Of Object) = subscriptions.GetOrAdd(GetType(T), Function() New List(Of Object)())
            SyncLock(subscribers)
                subscribers.Add(action)
            End SyncLock
        End Sub

        Public Sub Unsubscribe (Of T As IApplicationEvent)(action As Action(Of T)) Implements IEventAggregator.Unsubscribe
            Dim subscribers As New List(Of Object)
            If (subscriptions.TryGetValue(GetType(T), subscribers)) Then
                SyncLock(subscribers)
                    subscribers.Remove(action)
                End SyncLock
            End If
        End Sub

        Public Sub Dispose()
            subscriptions.Clear()
        End Sub
    End Class
End NameSpace