Imports MineProducts.Data.Config
Imports MineProducts.Data.Entities
Imports MineProducts.Data.Repositories.Interfaces

Namespace Repositories
    Public Class ProductSizeRepository
        Implements IProductSizeRepository(Of ProductSize)

        Public Property SessionManager As INHibernateSessionManager Implements IBaseRepository(Of ProductSize).SessionManager

        Public Sub New (sessionManager As INHibernateSessionManager)
            Me.SessionManager = sessionManager
        End Sub

        Public Function Create(productSize As ProductSize) As ProductSize Implements IBaseRepository(Of ProductSize).Create
            Using session = Me.SessionManager.OpenSession()
                Using transaccion = session.BeginTransaction()
                    session.Save(productSize)
                    transaccion.Commit()
                    return productSize
                End Using
            End Using
        End Function

        Public Function Update(productSize As ProductSize) As ProductSize Implements IBaseRepository(Of ProductSize).Update
            Using session = Me.SessionManager.OpenSession()
                Using transaccion = session.BeginTransaction()
                    session.Update(productSize)
                    transaccion.Commit()
                    return productSize
                End Using
            End Using
        End Function

        Public Function Delete(productSize As ProductSize) As ProductSize Implements IBaseRepository(Of ProductSize).Delete
            Using session = Me.SessionManager.OpenSession()
                Using transaccion = session.BeginTransaction()
                    session.Delete(productSize)
                    transaccion.Commit()
                    return productSize
                End Using
            End Using
        End Function

        Public Function FindById(productSize As Integer) As ProductSize Implements IBaseRepository(Of ProductSize).FindById
            Using session = Me.SessionManager.OpenSession()
                return session.QueryOver(Of ProductSize).
                    Where(Function(q) q.Id = productSize).
                    List().FirstOrDefault()
            End Using
        End Function

        Public Function FindAll() As ICollection(Of ProductSize) Implements IBaseRepository(Of ProductSize).FindAll
            Using session = Me.SessionManager.OpenSession()
                return session.QueryOver(Of ProductSize).List()
            End Using
        End Function
    End Class
End NameSpace