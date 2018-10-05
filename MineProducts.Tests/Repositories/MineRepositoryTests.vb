Imports MineProducts.Data.Config
Imports MineProducts.Data.Entities
Imports MineProducts.Data.Repositories

Namespace Repositories

    <TestClass()> Public Class MineRepositoryTests
        Private Property MineRepository As MineRepository

        <TestInitialize()>
        Public Sub Initialize()
            MineRepository = New MineRepository(new NHibernateSessionManager())
        End Sub

        Private Function CreateMine() As Mine
            Dim mine As new Mine With {
                .Name = "Vale"
            }
            MineRepository.Create(mine)
            Return mine
        End Function

        Private Function DeleteMine(mineId As Integer) As Mine
            Dim mine As new Mine With {
                .Id = mineId,
                .Name = "Vale"
            }
            MineRepository.Delete(mine)
            Return mine
        End Function

        <TestMethod()> Public Sub ShouldCreateMineAndSaveToDatabaseAndFindByIdAndDelete()
            Dim mine = CreateMine()

            Dim resultMine = mineRepository.FindById(mine.Id)

            Assert.IsNotNull(resultMine)
            Assert.IsTrue(resultMine.Id = mine.Id)

            DeleteMine(resultMine.Id)
        End Sub

        <TestMethod()> Public Sub ShouldUpdateMineAndSaveToDatabaseAndFindByIdAndDelete()
            Dim mine = CreateMine()
            Dim resultMine = mineRepository.FindById(mine.Id)
            resultMine.Name = "New Name"
            Me.MineRepository.Update(resultMine)
            resultMine = mineRepository.FindById(mine.Id)
            Assert.IsNotNull(resultMine)
            Assert.IsTrue(resultMine.Id = mine.Id)
            Assert.IsTrue(resultMine.Name = "New Name")
            DeleteMine(resultMine.Id)
        End Sub
    End Class
End NameSpace