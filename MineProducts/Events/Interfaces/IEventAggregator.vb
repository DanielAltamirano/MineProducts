Namespace Events.Interfaces
    Public Interface IEventAggregator
        Sub Publish(Of T As IApplicationEvent)(message As T)
        Sub Subscribe(Of T As IApplicationEvent)(action As Action(Of T))
        Sub Unsubscribe(Of T As IApplicationEvent)(action As Action(Of T))
    End Interface
End NameSpace