Imports System.Runtime.CompilerServices
Imports MineProducts.Models

Namespace Modules
    Module ProductExtensions
        <Extension()>
        Public Function FieldsNotNullOrEmpty(product As Product) As Boolean
            Return Not String.IsNullOrEmpty(product.ApplicationEndUse) And
                   Not String.IsNullOrEmpty(product.FumeClass) And
                   Not String.IsNullOrEmpty(product.ExplosiveDensity) And
                   Not String.IsNullOrEmpty(product.Name)
        End Function
    End Module
End NameSpace