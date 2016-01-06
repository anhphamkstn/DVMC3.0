Option Strict On
Option Explicit On 

'Dua ra ngoai de C# nhin thay
Public Enum DataEntryFormMode
    ' các giá trị dùng cho Form nhập dữ liệu
    UpdateDataState
    InsertDataState
    ViewDataState
    SelectDataState
End Enum

Public Class IPConstants

#Region "Nhiệm vụ của class"
    '****************************************************************************
    '*  Created by: Csung, 2003-11
    '*  Chứa các constants cho hệ thống eschool
    '*  Chú ý: phải là tầng thấp nhất ( không reference tới các class khác của hệ thống)
    '****************************************************************************
#End Region

#Region "Các giá trị kiểu Enum"

    Public Enum DataEntryFormMode
        ' các giá trị dùng cho Form nhập dữ liệu
        UpdateDataState
        InsertDataState
        ViewDataState
    End Enum

    Public Enum HowUserWantTo_Exit_MainForm
        Login_As_DifferentUser
        ExitFromSystem
    End Enum

    Public Enum FormMode
        'Phai chuyen ra ngoai de C# con tu dong thay
        ViewMode
        MaintainMode
        SelectMode
    End Enum
#End Region

#Region "Các giá trị Constants"
    Public Const c_DefaultDate As Date = #1/1/1900#
    Public Const c_DefaultDecimal As Decimal = 0
    Public Const c_DefaultString As String = ""

    ' USER này lúc nào cũng phải có trong hệ thống
    Public Const c_TenUserMacDinh As String = "ADMIN"

    ' các giá trị liên quan đến runmode
    Public Const C_RUNMODE_RUNTIME As String = "RUNTIME"
    Public Const C_RUNMODE_TEST As String = "TEST"
    Public Const C_RUNMODE_DEVELOP As String = "DEVELOP"
    Public Const C_RUNMODE_NOT_LOADED As String = "NOT_IDENTIFIED"

    'special characters
    Public Const C_DOUBLE_QUOTE As String = Chr(34)
    Public Const C_SINGLE_QUOTE As String = "'"
    '
    Public Shared ReadOnly Property C_StringType() As System.Type
        Get
            Return System.Type.GetType("System.String")
        End Get
    End Property

    Public Shared ReadOnly Property C_DecimalType() As System.Type
        Get
            Return System.Type.GetType("System.Decimal")
        End Get
    End Property


#End Region

#Region "Public Interface"


#End Region

End Class

Public Enum DirectoryFormMode
    ViewMode
    MaintainMode
    SelectMode
End Enum

