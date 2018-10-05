Imports AutoMapper
Imports MineProducts.Data.Repositories.Interfaces
Imports MineProducts.Models
Imports MineProducts.Services.Interfaces

Namespace Services
    Public Class MineService
        Implements IMineService

        Private ReadOnly _mapper As IMapper
        Private ReadOnly _mineRepository As IMineRepository(Of Data.Entities.Mine)

        Public Sub New(mapper As IMapper, mineRepository As IMineRepository(Of Data.Entities.Mine))
            _mapper = mapper
            _mineRepository = mineRepository
        End Sub

        Public Sub Create(mine As Models.Mine) Implements IMineService.Create
            Dim mineEntity As Data.Entities.Mine = _mapper.Map(Of Models.Mine, Data.Entities.Mine)(mine)
            _mineRepository.Create(mineEntity)
        End Sub

        Public Sub Update(mine As Mine) Implements IMineService.Update
            Dim mineEntity As Data.Entities.Mine = _mapper.Map(Of Models.Mine, Data.Entities.Mine)(mine)
            _mineRepository.Update(mineEntity)
        End Sub

        Public Function FindAll() As ICollection(Of Models.Mine) Implements IMineService.FindAll
            Dim entityMines = _mineRepository.FindAll()
            Dim modelMines = New List(Of Models.Mine)
            For Each mine As Data.Entities.Mine In entityMines
                modelMines.Add(_mapper.Map(Of Data.Entities.Mine, Models.Mine)(mine))
            Next
            Return modelMines
        End Function
    End Class
End NameSpace