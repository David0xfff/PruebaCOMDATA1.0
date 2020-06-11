Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports comandata1

Namespace Controllers
    Public Class REGISTROesController
        Inherits System.Web.Mvc.Controller

        Private db As New COMANDATA_DATABASEEntities

        ' GET: REGISTROes
        Function Index() As ActionResult
            Return View(db.REGISTRO.ToList())
        End Function

        ' GET: REGISTROes/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim rEGISTRO As REGISTRO = db.REGISTRO.Find(id)
            If IsNothing(rEGISTRO) Then
                Return HttpNotFound()
            End If
            Return View(rEGISTRO)
        End Function

        ' GET: REGISTROes/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: REGISTROes/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="NOMBRE,APELLIDO,DIRECCCION,TELEFONO,SALARIO,AREA,FECHA_INGRESO,SEXO,CODIGO,JEFE,TRABAJADOR_A_CARGO")> ByVal rEGISTRO As REGISTRO) As ActionResult
            If ModelState.IsValid Then
                db.REGISTRO.Add(rEGISTRO)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(rEGISTRO)
        End Function

        ' GET: REGISTROes/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim rEGISTRO As REGISTRO = db.REGISTRO.Find(id)
            If IsNothing(rEGISTRO) Then
                Return HttpNotFound()
            End If
            Return View(rEGISTRO)
        End Function

        ' POST: REGISTROes/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="NOMBRE,APELLIDO,DIRECCCION,TELEFONO,SALARIO,AREA,FECHA_INGRESO,SEXO,CODIGO,JEFE,TRABAJADOR_A_CARGO")> ByVal rEGISTRO As REGISTRO) As ActionResult
            If ModelState.IsValid Then
                db.Entry(rEGISTRO).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(rEGISTRO)
        End Function

        ' GET: REGISTROes/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim rEGISTRO As REGISTRO = db.REGISTRO.Find(id)
            If IsNothing(rEGISTRO) Then
                Return HttpNotFound()
            End If
            Return View(rEGISTRO)
        End Function

        ' POST: REGISTROes/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim rEGISTRO As REGISTRO = db.REGISTRO.Find(id)
            db.REGISTRO.Remove(rEGISTRO)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
