# Findex 

# Proyecto: 
    1- Crear un proyecto ASP.NET Core 
    2- Convertir a clase este JSON 
    3- Utilizar Tiny Mapper para mapear el JSON anterior a este
    4- Crear un controlador con un endpoint que reciba el primer JSON y devuelva como response el segun

# Arquitecura de la solución 
    La arquitectura de la aplicación esta inspirada en Clean Architecture y podemos apreciar la siguiente estructura de carpetas
    1- Core:  Se encuentra la definición de las entities principales de la solución.
    2- Utils: Acá colocamos aquella clase, métodos de uso común que aportan a toda la solución 
    3- Application: Donde se encuentra nuestra WebAPI, los métodos que exponemos a un cliente para que sean consumidos a través de controladores.

    La solución esta desarrollada en Netcore 6.0 , lenguaje c#

