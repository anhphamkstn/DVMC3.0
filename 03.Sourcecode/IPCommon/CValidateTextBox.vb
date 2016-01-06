option Strict on
option explicit On 

imports System.Windows.forms


public Enum allowNull
    YES = 0
    NO = 1
End Enum

Public Class CValidateTextBox
    
    public shared function IsValid(ByVal i_txtCtrl As TextBox _
                , ByVal i_DataType As DataType _
                , ByVal i_AllowNull As ALLOWNULL _
                , optional byval i_displayDefaultMsg as Boolean = true) As Boolean
        

        dim v_textbox_is_valid as Boolean 
        Dim v_strText As String = i_txtCtrl.Text
        if v_strText = "" then 
            'Kiem tra dieu kien rong
            select case i_Allownull 
                case AllowNull.NO
                    if i_displayDefaultMsg then 
                        basemessages.MsgBox_Warning(1)
                    end if
                    v_textbox_is_valid = false
                case allowNull.YES
                    v_textbox_is_valid = true
            end select
        else  'Trong truong hop khac rong 
            Select Case i_DataType
                Case DataType.NumberType
                    v_textbox_is_valid =  cutil.isValidNumber(v_strText, False)
                    if i_displayDefaultMsg and not v_textbox_is_valid then 
                        basemessages.MsgBox_Warning(12)
                    End If
                Case DataType.DateType
                    v_textbox_is_valid =  CDateTime.isValidDateString(v_strText, CDateTime.GetDateFormatString())
                    if i_displayDefaultMsg and not v_textbox_is_valid then 
                          basemessages.MsgBox_Warning(14)  
                    End If
                Case DataType.StringType
                    v_textbox_is_valid = true
            End Select
        end if 

        if not v_textbox_is_valid then 
            CErrorTextBoxHandler.markAsErrorTxtBox(i_txtCtrl)            
        End If
        return v_textbox_is_valid
    END Function
End Class


