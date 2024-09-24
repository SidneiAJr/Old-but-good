from tkinter import *
from tkinter import ttk
from tkinter import messagebox
from reportlab.pdfgen import canvas
from reportlab.lib.pagesizes import A4
import os

def mp(mm):
    return mm/0.3527777

pastaApp=os.path.dirname(__file__)


def criarpdf():
   try:
      cnv=canvas.Canvas(pastaApp+"\\X.pdf", pagesize=A4)
      cnv.drawString(mp(100),mp(100),"Curso de PY")
      cnv.save()
   except:
    messagebox.showinfo(title="Erro",message="Erro ao criar arquivo PDF")
   return
messagebox.showinfo(title="PDF",message="PDF Criado!!!")            


app=Tk()
app.title('Gerador de PDF dos Guri Brabo do dale')
app.geometry("620x600")


btn_criarPDF=Button(app,text="Criar PDF", command=criarpdf)
btn_criarPDF.pack(side="left", padx=10)

app.mainloop()
