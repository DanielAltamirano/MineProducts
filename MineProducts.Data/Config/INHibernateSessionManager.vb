Imports NHibernate

Namespace Config
    Public Interface INHibernateSessionManager
        Function OpenSession As ISession
    End Interface
End NameSpace