Imports AutoMapper
Imports MineProducts.Data.Config
Imports MineProducts.Data.Entities
Imports MineProducts.Data.Repositories
Imports MineProducts.Data.Repositories.Interfaces
Imports MineProducts.Events
Imports MineProducts.Events.Interfaces
Imports MineProducts.Presenters.Interfaces
Imports MineProducts.Services
Imports MineProducts.Services.Interfaces
Imports MineProducts.Views
Imports MineProducts.Views.Interfaces
Imports Unity
Imports Unity.Injection
Imports MineProducts.Presenters.MainView
Imports MineProducts.Presenters.MineView
Imports MineProducts.Presenters.ProductView

Namespace Config
    Public Class UnityConfig
        Private Shared ReadOnly Property Container As Lazy(Of UnityContainer)
            Get
                Container = New Lazy(Of UnityContainer)()
                RegisterTypes(Container.Value)
                Return Container
            End Get
        End Property

        Private Shared Sub RegisterTypes(c As UnityContainer)
            c.RegisterType(Of INHibernateSessionManager, NHibernateSessionManager)(nameof(NHibernateSessionManager))
            c.RegisterInstance(nameof(IMapper), MapperConfig.GetConfiguredMapper())
            c.RegisterInstance(nameof(IEventAggregator), EventAggregator.Events)
            c.RegisterType(Of IMineRepository(Of Mine), MineRepository)(nameof(MineRepository),
                New InjectionConstructor(
                    New ResolvedParameter(Of INHibernateSessionManager)(nameof(NHibernateSessionManager))
                )
            )
            c.RegisterType(Of IProductSizeRepository(Of ProductSize), ProductSizeRepository)(nameof(ProductSizeRepository),
                New InjectionConstructor(
                    New ResolvedParameter(Of INHibernateSessionManager)(nameof(NHibernateSessionManager))
                )
            )
            c.RegisterType(Of IProductRepository(Of Product), ProductRepository)(nameof(ProductRepository),
                New InjectionConstructor(
                    New ResolvedParameter(Of INHibernateSessionManager)(nameof(NHibernateSessionManager))
                )
            )
            c.RegisterType(Of IMineService, MineService)(nameof(MineService),
                New InjectionConstructor(
                    New ResolvedParameter(Of IMapper)(nameof(IMapper)),
                    New ResolvedParameter(Of IMineRepository(Of Mine))(nameof(MineRepository))
                )
            )
            c.RegisterType(Of IProductSizeService, ProductSizeService)(nameof(ProductSizeService),
                New InjectionConstructor(
                    New ResolvedParameter(Of IMapper)(nameof(IMapper)),
                    New ResolvedParameter(Of IProductSizeRepository(Of ProductSize))(nameof(ProductSizeRepository))
                )
            )
            c.RegisterType(Of IProductService, ProductService)(nameof(ProductService),
                    New InjectionConstructor(
                    New ResolvedParameter(Of IMapper)(nameof(IMapper)),
                    New ResolvedParameter(Of IProductRepository(Of Product))(nameof(ProductRepository))
                )
            )
            c.RegisterType(Of IMineView, MineView)(nameof(MineView),
                New InjectionConstructor(
                    New ResolvedParameter(Of IEventAggregator)(NameOf(IEventAggregator))
                )
            )
            c.RegisterType(Of IMineViewPresenter, MineViewPresenter)(nameof(MineViewPresenter),
                New InjectionConstructor(
                    New ResolvedParameter(Of IMineView)(nameof(MineView)),
                    New ResolvedParameter(Of IMineService)(nameof(MineService)),
                    New ResolvedParameter(Of IEventAggregator)(NameOf(IEventAggregator))
                )
            )
            c.RegisterType(Of IProductView, ProductView)(nameof(ProductView),
                New InjectionConstructor(
                    New ResolvedParameter(Of IEventAggregator)(NameOf(IEventAggregator))
                )
            )
            c.RegisterType(Of IProductViewPresenter, ProductViewPresenter)(nameof(ProductViewPresenter),
                New InjectionConstructor(
                    New ResolvedParameter(Of IProductView)(NameOf(ProductView)),
                    New ResolvedParameter(Of IMineService)(NameOf(MineService)),
                    New ResolvedParameter(Of IProductService)(NameOf(ProductService)),
                    New ResolvedParameter(Of IEventAggregator)(NameOf(IEventAggregator))
                )
            )
            c.RegisterType(Of IMainFormView, MainFormView)(nameof(MainFormView),
                New InjectionConstructor(
                    New ResolvedParameter(Of IEventAggregator)(NameOf(IEventAggregator))
                )
            )
            c.RegisterType(Of MainViewPresenter)(
                New InjectionConstructor(
                    New ResolvedParameter(Of IMainFormView)(nameof(MainFormView)),
                    New ResolvedParameter(Of IMineViewPresenter)(nameof(MineViewPresenter)),
                    New ResolvedParameter(Of IProductViewPresenter)(nameof(ProductViewPresenter)),
                    New ResolvedParameter(Of IMineService)(nameof(MineService)),
                    New ResolvedParameter(Of IProductService)(nameof(ProductService)),
                    New ResolvedParameter(Of IProductSizeService)(nameof(ProductSizeService)),
                    New ResolvedParameter(Of IEventAggregator)(NameOf(IEventAggregator))
                )
            )
        End Sub

        Public Shared Function GetConfiguredContainer() As UnityContainer
            Return Container.value
        End Function
    End Class
End NameSpace