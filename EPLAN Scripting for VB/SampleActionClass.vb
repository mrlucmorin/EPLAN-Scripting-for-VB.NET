
'Luc Morin(MRN), July 2018
'Small script To save labels To a folder created based On a project Property 
'It adds a New Action To Eplan: SaveLabelsToFolder
'This action can be called either from a toolbar button, Or from a script
'Simply "load" the script in Eplan (don't "run" it). 




'The following compiler directive Is necessary To enable editing scripts
'within Visual Studio.
'It requires that the "Conditional compilation symbol" SCRIPTENV be defined 
'in the Visual Studio project properties
'This Is because EPLAN's internal scripting engine already adds "Imports directives"
'when you load the script in EPLAN. Having them twice would cause errors.


#If SCRIPTENV Then
Imports EPLAN.EplApi.ApplicationFramework
Imports EPLAN.EplApi.Scripting
Imports EPLAN.EplApi.Base
Imports EPLAN.EplApi.Gui
#End If


'On the other hand, some namespaces are Not automatically added by EPLAN when
'you load a script. Those have To be outside Of the previous conditional compiler directive


Imports System
Imports System.IO
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Linq



Public Class SampleActionClass

    'Declare the script Action
    <DeclareAction("SampleAction")>
    Public Sub Action()
        MsgBox("SampleAction called")
    End Sub

End Class
