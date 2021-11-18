# Arquitectura_Software_Laboratorio_6
#### Alvaro Bryan Cori Sanchez
#### Laboratorio 6: Implentacion de un patron o modelo arquitectonico monolitico
## Arquitectura Hexagonal

La arquitectura hexagonal es un modelo monolitico que tiene como objetivo 
esta arquitectura se suele presentar con forma de hexágono, aunque el número de lados no importan, sino lo que estos representan. Cada lado representa un puerto hacia dentro o fuera de la aplicación. Un puerto puede ser un HTTP para hacer peticiones a nuestra aplicación, otro puerto se le puede aplicar SOAP que tambien hace peticiones.
La forma de acceder a las capas internas es mediante adaptares para cada puerto el cual nos permita acceder y usar
los recursos de mas adentro.
El modelo de la arquitectura la podemos dividir en 3 capas.
* Dominio .- Es el nucleo de la arquitectura que contiene los repositorios.
* Aplicacion .- Es un capa donde se aplica las reglas de negocio sobre la informacion que entre.
* Infraestructura .- Son los controladores que reciben los datos desde varios sitios como en un REST, una base de datos, HTML etc.
Los adaptadores se los aplica usando el principio de inversion el cual pide usar implementaciones (interfaces) en vez de una clase concreta, asi que cuando quedramos podemos cambiar facilmente las clases heredando de la implementacion.

## Servicio REST para una panaderia

Una panaderia quiere registrar sus ventas usando un servicio REST en un servidor local en un principio quiere ser versatil en añadir funciones a su sistema por lo que necesitan un modelo que pueda adaptar las necesidades de los dueños de la panaderia.

En un principio se quiere registrar el producto vendido, precio, cantidad y informacion como que tipo de producto como puede ser panes, pies, empanadas, pasteles, etc.

Tambien se pidio que el sistema saque un resumen de las ventas en base al tipo de producto como por ejemplo cuanto se gano vendiendo pan, que cantidades se llevaron y cuantas ventas se registro.