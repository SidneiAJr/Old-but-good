import tkinter as tk
from tkinter import ttk

def mostrar_nome_completo():
    nome = entry_nome.get()
    sobrenome = entry_sobrenome.get()
    nome_completo = f"Nome completo:{nome} {Sobrenome}"
    label_nome_completo.config(text=nome_completo)

janela = tk.Tk() 
janela.title("Capture o texto")

label_nome =  ttk.Label(janela , text="nome")
label_nome.grid(row=0, column=0 , padx=10 pady=5 sticky="e")