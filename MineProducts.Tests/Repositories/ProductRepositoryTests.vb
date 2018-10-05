Imports MineProducts.Data.Config
Imports MineProducts.Data.Entities
Imports MineProducts.Data.Repositories

Namespace Repositories

    <TestClass()> Public Class ProductRepositoryTests
        Private Property ProductRepository As ProductRepository
        Private Property MineRepository As MineRepository

        <TestInitialize()>
        Public Sub Initialize()
            MineRepository = New MineRepository(new NHibernateSessionManager())
            ProductRepository = New ProductRepository(new NHibernateSessionManager())
        End Sub

        Private Function CreateMine() As Mine
            Dim mine As new Mine With {
                .Name = "Vale"
            }
            MineRepository.Create(mine)
            Return mine
        End Function

        Private Function CreateProduct() As Product
            Dim mine = CreateMine()
            Dim product As New Product With {
                .Name = "Minerite 1",
                .ApplicationEndUse = "Underground Tunneling",
                .FumeClass = "UN-1",
                .Mine = mine
            }
            product = ProductRepository.Create(product)
            Return product
        End Function

        Private Function DeleteProduct(productId As Integer) As Product
            Dim product As New Product With {
                .Id = productId
            }
            product = ProductRepository.Delete(product)
            Return product
        End Function

        Private Function DeleteMine(mineId As Integer) As Mine
            Dim mine As new Mine With {
                .Id = mineId,
                .Name = "Vale"
            }
            MineRepository.Delete(mine)
            Return mine
        End Function

        <TestMethod()> Public Sub ShouldCreateProductAndSaveToDatabaseAndFindByIdAndDelete()
            Dim product = CreateProduct()

            Dim resultProduct = ProductRepository.FindById(product.Id)

            Assert.IsNotNull(resultProduct)
            Assert.IsTrue(resultProduct.Id = product.Id)
            Assert.IsTrue(resultProduct.Mine.Id = product.Mine.Id)

            DeleteProduct(resultProduct.Id)
            DeleteMine(resultProduct.Mine.Id)

            resultProduct = ProductRepository.FindById(product.Id)
            Assert.IsNull(resultProduct)

            Dim resultMine = MineRepository.FindById(product.Mine.Id)
            Assert.IsNull(resultMine)
        End Sub

        <TestMethod()> Public Sub ShouldUpdateMineAndSaveToDatabaseAndFindByIdAndDelete()
            Dim product = CreateProduct()

            Dim resultProduct = ProductRepository.FindById(product.Id)

            Assert.IsNotNull(resultProduct)
            Assert.IsTrue(resultProduct.Id = product.Id)
            Assert.IsTrue(resultProduct.Mine.Id = product.Mine.Id)

            product.FumeClass = "UN-2"
            product.ApplicationEndUse = "Mountain blasting"

            ProductRepository.Update(product)

            resultProduct = ProductRepository.FindById(product.Id)

            Assert.IsNotNull(resultProduct)
            Assert.IsTrue(resultProduct.Id = product.Id)
            Assert.IsTrue(resultProduct.Mine.Id = product.Mine.Id)
            Assert.IsTrue(resultProduct.FumeClass = product.FumeClass)
            Assert.IsTrue(resultProduct.ApplicationEndUse = product.ApplicationEndUse)

            DeleteProduct(resultProduct.Id)
            DeleteMine(resultProduct.Mine.Id)

            resultProduct = ProductRepository.FindById(product.Id)
            Assert.IsNull(resultProduct)

            Dim resultMine = MineRepository.FindById(product.Mine.Id)
            Assert.IsNull(resultMine)
        End Sub
    End Class
End NameSpace