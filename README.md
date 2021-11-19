# Arquitectura_Software_Laboratorio_6
#### Alvaro Bryan Cori Sanchez
#### Laboratorio 6: Implentacion de un patron o modelo arquitectonico monolitico
## Arquitectura Hexagonal
![diagrama_de_clases](https://github.com/AlvaroCori/Arquitectura_Software_Laboratorio_6/blob/main/img/figura_hexagonal.png)
### Imagen obtenida por internet
La arquitectura hexagonal es un modelo monolitico que se suele presentar con forma de hexágono, aunque el número de lados no importan, sino lo que estos representan. Cada lado representa un puerto hacia dentro o fuera de la aplicación. Un puerto puede ser un HTTP para hacer peticiones a nuestra aplicación, otro puerto se le puede aplicar SOAP que tambien hace peticiones.
La forma de acceder a las capas internas es mediante adaptares para cada puerto el cual nos permita acceder y usar
los recursos de mas adentro.
El modelo de la arquitectura la podemos dividir en 3 capas.
* Dominio .- Es el nucleo de la arquitectura que contiene modelos que representan la informacion del la aplicacion.
* Aplicacion .- Es un capa donde se aplica las reglas de negocio sobre la informacion que entre.
* Infraestructura .- Son los controladores que reciben los datos desde varios sitios como en un REST, una base de datos, HTML etc.
Los adaptadores se los aplica usando el principio de inversion el cual pide usar implementaciones (interfaces) en vez de una clase concreta, asi que cuando quedramos podemos cambiar facilmente las clases heredando de la implementacion.

## Servicio REST para una panaderia

Una panaderia quiere registrar sus ventas usando un servicio REST en un servidor local en un principio quiere ser versatil en añadir funciones a su sistema por lo que necesitan un modelo que pueda adaptar las necesidades de los dueños de la panaderia.

En un principio se quiere registrar el producto vendido, precio, cantidad y informacion como que tipo de producto como puede ser panes, pies, empanadas, pasteles, etc.

Tambien se pidio que el sistema saque un resumen de las ventas en base al tipo de producto como por ejemplo cuanto se gano vendiendo pan, que cantidades se llevaron y cuantas ventas se registro.
## Diagrama de Hexagono
![diagrama_de_clases](https://github.com/AlvaroCori/Arquitectura_Software_Laboratorio_6/blob/main/img/Diagrama_Hexagonal.jpg)
### Elaboracion propia

En el diagrama la solucion se muestra en un modelo hexagonal donde en un flujo tenemos al registro de ventas el cual se puede crear y ver las ventas creadas, por otro flujo se puede obtener los resumenes de las ventas mientras que en otra parte guardamos las ventas para usarlas despues. 
Este sistema monolitico se puede registrar y en otro flujo obtener los resumenes desde el repositorio, por supuesto esta arquitectura es expandible para las futuras expansiones.
* Dominio .- Contiene las entidades del negocio (entidad del producto).
* Aplicacion .- Contiene servicios y un repositorio con modelos que son convertidos a entidades.
* Infraestructura .- Contiene los controladores.
# C4
El diagrama de capas de la aplicacion es la siguiente:


## Primera Capa
![diagrama_de_clases](https://github.com/AlvaroCori/Arquitectura_Software_Laboratorio_6/blob/main/img/1er_nivel.jpg)
### Elaboracion propia


## Segunda Capa
![diagrama_de_clases](https://github.com/AlvaroCori/Arquitectura_Software_Laboratorio_6/blob/main/img/2do_nivel.jpg)
### Elaboracion propia


## Tercera Capa
![diagrama_de_clases](https://github.com/AlvaroCori/Arquitectura_Software_Laboratorio_6/blob/main/img/3_nivel.jpg)
### Elaboracion propia


## Cuarta Capa
![diagrama_de_clases](https://github.com/AlvaroCori/Arquitectura_Software_Laboratorio_6/blob/main/img/4_nivel.jpg)
### Elaboracion propia



# Recursos

Se agrego BakeryAPI.postman_collection.json el cual corriendo la aplicacion y con el puerto 3030 se puede simular a las personas que usaran la aplicacion.

Productos

GET / CREATE (requiere los campos de la entidad vease capa 4 (ProductEntity), el id se lo autoasigna).

http://localhost:3030/api/products

Resumenes

GET 

http://localhost:3030/api/OverviewsProduct
