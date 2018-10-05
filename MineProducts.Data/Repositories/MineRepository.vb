Imports MineProducts.Data.Config
Imports MineProducts.Data.Entities
Imports MineProducts.Data.Repositories.Interfaces

Namespace Repositories
    Public Class MineRepository
        Implements IMineRepository (Of Mine)

        Public Sub New (sessionManager As INHibernateSessionManager)
            Me.SessionManager = sessionManager
        End Sub

        Public Property SessionManager As INHibernateSessionManager Implements IMineRepository(Of Mine).SessionManager

        Public Function Create(mine As Mine) As Mine Implements IMineRepository(Of Mine).Create
            Using session = Me.SessionManager.OpenSession()
                Using transaccion = session.BeginTransaction()
                    session.Save(mine)
                    transaccion.Commit()
                    return mine
                End Using
            End Using
        End Function

        Public Function Update(mine As Mine) As Mine Implements IMineRepository(Of Mine).Update
            Using session = Me.SessionManager.OpenSession()
                Using transaccion = session.BeginTransaction()
                    session.Update(mine)
                    transaccion.Commit()
                    return mine
                End Using
            End Using
        End Function

        Public Function Delete(mine As Mine) As Mine Implements IMineRepository(Of Mine).Delete
            Using session = Me.SessionManager.OpenSession()
                Using transaccion = session.BeginTransaction()
                    session.Delete(mine)
                    transaccion.Commit()
                    return mine
                End Using
            End Using
        End Function

        Public Function FindById(mine As Integer) As Mine Implements IMineRepository(Of Mine).FindById
            Using session = Me.SessionManager.OpenSession()
                return session.QueryOver(Of Mine).
                    Where(Function(q) q.Id = mine).
                    List().FirstOrDefault()
            End Using
        End Function

        Public Function FindAll() As ICollection(Of Mine) Implements IMineRepository(Of Mine).FindAll
            Using session = Me.SessionManager.OpenSession()
                return session.QueryOver(Of Mine).List()
            End Using
        End Function
    End Class
End NameSpace