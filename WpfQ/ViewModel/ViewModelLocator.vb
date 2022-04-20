Imports CommonServiceLocator
Imports GalaSoft.MvvmLight.Ioc
Imports WpfQ.ViewModel
Namespace ViewModel
    Public Class ViewModelLocator
        Public Sub New()
            ServiceLocator.SetLocatorProvider(Function() SimpleIoc.Default)

            SimpleIoc.Default.Register(Of MainViewModel)()
        End Sub
        Public ReadOnly Property Main As MainViewModel
            Get
                Return ServiceLocator.Current.GetInstance(Of MainViewModel)()
            End Get
        End Property
        Public Shared Sub Cleanup()
            'TODO clear the Viewmodels
        End Sub
    End Class
End Namespace

