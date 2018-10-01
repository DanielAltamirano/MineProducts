Imports System.Reflection
Imports FluentNHibernate.Cfg
Imports FluentNHibernate.Cfg.Db
Imports NHibernate
Imports NHibernate.Tool.hbm2ddl

Namespace Config

    Public Class NHibernateSessionManager
        Implements INHibernateSessionManager

        Private Shared Property SessionFactory As ISessionFactory

        Public Sub New 
            CreateSessionFactory()
        End Sub

        Private Shared Sub CreateSessionFactory
            SessionFactory = Fluently.Configure().
                Database(MsSqlConfiguration.
                            MsSql2012.ConnectionString(
                                Configuration.ConfigurationManager.ConnectionStrings("MSSQLLocalDB").ConnectionString)).
                Mappings(Function(x) x.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())).
                ExposeConfiguration(
                    Sub(config)
                        Dim schemaExport As New SchemaUpdate(config)
                        schemaExport.Execute(False, True)
                    End Sub
                ).
                BuildSessionFactory()
        End Sub

        Public Function OpenSession() As ISession Implements INHibernateSessionManager.OpenSession
            return SessionFactory.OpenSession()
        End Function

    End Class
End NameSpace