Option Explicit On 
Option Strict On

Public Enum SearchType
    fromStart = 0
    fromNextRow = 1
End Enum

Public Interface ISearchable
    Function startSearch(ByVal i_PatternSearch As IFoundCondition, _
                         ByVal i_SearchType As SearchType) As Boolean
End Interface

Public Interface IFoundCondition
    Function MatchThePattern(ByVal i_Data2Compare As Object) As Boolean
End Interface

Public Interface ISearchForm
    Sub displaySearch(ByVal i_form2Search As ISearchable)
End Interface