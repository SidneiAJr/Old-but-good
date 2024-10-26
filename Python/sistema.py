from tkinter import *
from tkinter import messagebox
from tkinter import ttk

jan = Tk()
jan.title("Painel de Acesso")
jan.geometry("600x300")
jan.configure(background="white")
jan.resizable(width=False, height=False)

logo = PhotoImage(file="icons/logo.png")

LeftFrame = Frame(jan, width=200, height=300 , bg="black", relief="raise")
LeftFrame.pack(side=LEFT)

RightFrame = Frame(jan, width=395, height=300 , bg="blue", relief="raise")
RightFrame.pack(side=RIGHT)

LogoLabel = Label(LeftFrame,image=logo, bg="black")
LogoLabel.place(x=50 , y=100)

UserLabel= Label(RightFrame, text="Usuario")
UserLabel.place(x=5,y=100)

UserEntrey = ttk.Entry(RightFrame , width=20)
UserEntrey.place(x=50 , y=100)

PassLabel =Label(RightFrame, text="Senha:")
PassLabel.place(x=6 , y=130)

PassEntry = ttk.Entry(RightFrame ,width=20)
PassEntry.place(x=45,y=130)

LoginButton = ttk.Button(RightFrame, text="Login" ,width=10)
LoginButton.place(x=20,y=150)

RegisterButton = ttk.Button(RightFrame, text="Registrar" ,width=10)
RegisterButton.place(x=100,y=150)





jan.mainloop()

