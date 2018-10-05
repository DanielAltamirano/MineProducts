Imports MineProducts.Data.Config
Imports MineProducts.Data.Entities
Imports MineProducts.Data.Repositories.Interfaces

Namespace Repositories

    Public Class ProductRepository
        Implements IProductRepository (Of Product)

        Public Property SessionManager As INHibernateSessionManager Implements IBaseRepository(Of Product).SessionManager

        Public Sub New (sessionManager As INHibernateSessionManager)
            Me.SessionManager = sessionManager
        End Sub

        Public Function Create(product As Product) As Product Implements IBaseRepository(Of Product).Create
            Using session = Me.SessionManager.OpenSession()
                Using transaccion = session.BeginTransaction()
                    session.Save(product)
                    transaccion.Commit()
                    return product
                End Using
            End Using
        End Function

        Public Function Update(product As Product) As Product Implements IBaseRepository(Of Product).Update
            Using session = SessionManager.OpenSession()
                Using transaccion = session.BeginTransaction()
                    session.Update(product)
                    transaccion.Commit()
                    return product
                End Using
            End Using
        End Function

        Public Function Delete(product As Product) As Product Implements IBaseRepository(Of Product).Delete
            Using session = Me.SessionManager.OpenSession()
                Using transaccion = session.BeginTransaction()
                    session.Delete(product)
                    transaccion.Commit()
                    return product
                End Using
            End Using
        End Function

        Public Function FindById(product As Integer) As Product Implements IBaseRepository(Of Product).FindById
            Using session = Me.SessionManager.OpenSession()
                return session.QueryOver(Of Product).
                    Where(Function(q) q.Id = product).
                    List().FirstOrDefault()
            End Using
        End Function

        Public Function FindAll() As ICollection(Of Product) Implements IBaseRepository(Of Product).FindAll
            Using session = Me.SessionManager.OpenSession()
                return session.QueryOver(Of Product).List()
            End Using
        End Function

        Public Function FindAll(mineId As Integer) As ICollection(Of Product) Implements IProductRepository(Of Product).FindAll
            Using session = SessionManager.OpenSession()
                Return session.QueryOver(Of Product).Where(Function(x) x.Mine.Id = mineId).List()
            End Using
        End Function
    End Class
End NameSpace