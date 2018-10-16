Namespace My
    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        'Override the linger time for the splash screen
        Protected Overrides Function OnInitialize( _
            ByVal commandLineArgs As  _
            System.Collections.ObjectModel.ReadOnlyCollection(Of String) _
        ) As Boolean
            ' Set the display time to 10000 milliseconds (10 seconds). 
            Me.MinimumSplashScreenDisplayTime = 10000
            Return MyBase.OnInitialize(commandLineArgs)

        End Function

        'Handler for unhandled exceptions
        Public Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            MessageBox.Show("Unhandled Exception from " & sender.ToString)
        End Sub
    End Class


End Namespace

