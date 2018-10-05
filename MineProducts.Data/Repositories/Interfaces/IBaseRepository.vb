Imports MineProducts.Data.Config

Namespace Repositories.Interfaces
    Public Interface IBaseRepository(Of T)
        Property SessionManager As INHibernateSessionManager

        Function Create(item As T) As T

        Function Update(item As T) As T

        Function Delete(item As T) As T

        Function FindById(item As Integer) As T

        Function FindAll() As ICollection(Of T)
    End Interface
End NameSpace