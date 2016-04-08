Public Class frmMain

    Dim totalMemory As Decimal
    Dim availableMemory As Decimal
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblDisplayCPUName.Text =
My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\SYSTEM\CentralProcessor\0",
"ProcessorNameString", Nothing).ToString

        lblDisplayComputerName.Text = System.Environment.MachineName

        lblDisplayUserName.Text = System.Environment.UserName

        lblDisplayOperatingSystem.Text = My.Computer.Info.OSFullName

        lblDisplayOSPlatform.Text = My.Computer.Info.OSPlatform

        lblDisplayOSVersion.Text = My.Computer.Info.OSVersion

        lblDisplayLanguage.Text = My.Computer.Info.InstalledUICulture.ToString

        totalMemory = CDec(Math.Round(My.Computer.Info.TotalPhysicalMemory / 1024 * 1024, 2))
        lblDisplayTotalMemory.Text = totalMemory.ToString("n") & "MB"

    End Sub

    Private Sub tmrDisplayMemory_Tick(sender As Object, e As EventArgs) Handles tmrDisplayMemory.Tick
        availableMemory = CDec(Math.Round(My.Computer.Info.AvailablePhysicalMemory / 1024 * 1024, 2))
        lblDisplayAvailableMemory.Text = availableMemory.ToString("n") & "MB"
    End Sub
End Class
