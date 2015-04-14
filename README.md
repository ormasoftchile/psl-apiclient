#psl-apiclient
Biblioteca .NET que permite acceder a los servicios de la API Pasamonte Labs.
Encapsula invocaciones REST a través de una biblioteca de clases, facilitando realizar la integración con los servicios.
El servicio REST también es accesible a través de HTTP. En la parte inferior de esta descripción se presentan ejemplos de invocaciones utilizando el utilitario de comandos *curl*.

##Los servicios disponibles se enmarcan en dos categorías:

### Integración con Registro Clínico Electrónico (RCE). (Actualmente se implementa la interoperabilidad con la plataforma SAYDEX).
* Validación de usuarios (pacientes) en plataforma RCE.
* Obtención de recetas con despachos pendientes desde RCE.
* Registro (notificación) de despachos realizados a RCE.

###Integración con operaciones de
* Citas médicas
* Administración de turnos (Servicios, Módulos, Turnos)

###Funcionalidades del servicio
* RceAutenticar
* RceCambiarClave
* RceObtenerEntregas
* RceNotificarEntrega
* RceRegistrarCita
* RceConfirmarCita
* RceCancelarCita
* RceObtenerCitas
* RegistrarServicio
* EliminarServicio
* ObtenerServicios
* RegistrarModulo
* EliminarModulo
* ObtenerModulos
* RegistrarTurno
* EliminarTurno
* ObtenerTurnos
* ObtenerTerminales

###Vea la documentación de los objetos en [Docs psl-apiclient](http://pasamonte.github.io/docs/psl-apiclient)

##Uso de los métodos desde línea de comandos
Se puede acceder a los métodos utilizando *curl* desde la línea de comandos, siguiendo los parámetros indicados en la documentación de cada método.
En cada llamada se debe proveer el parámetro **apiKey** y debe invocarse utilizando el verbo **POST**.

**Ejemplo:**
* Para obtener una lista de los terminales registrados en el sistema, un comando posible es:
```
curl -H "Content-Type: application/json" -i \
     -X POST http://ppi.cloudapp.net/api/adm/obtenerterminales \
     -d "{ 'apiKey': 'a34287f8-102a-4cf3-bace-153c30c3eb58', \
           'idTerminal': 'a34287f8-102a-4cf3-bace-153c30c3eb58' }"
```           
* Para obtener los datos de un terminal específico, se agrega el id del terminal como parámetro:
```
curl -H "Content-Type: application/json" -i \
     -X POST http://ppi.cloudapp.net/api/adm/obtenerterminales \
     -d "{ 'apiKey': 'a34287f8-102a-4cf3-bace-153c30c3eb58', \
           'idTerminal': 'a34287f8-102a-4cf3-bace-153c30c3eb58', \
           'id': '7a873d2f-181d-4c23-90c4-176897f47382' }"
```
* Para crear un servicio, debemos proveer los siguientes parámetros:
```
+-----------------------------------------------------------------------------------------------------+
| parámetro              |  opcional |  valor por defecto   |                 ejemplo                 |
+-----------------------------------------------------------------------------------------------------+
| id                     |     sí    |        <nulo>        |   75e48afb-25dd-447a-a864-15992ec070b4  |
+-----------------------------------------------------------------------------------------------------+
|      titulo            |     no    |                      |   servicio de prueba                    |
+-----------------------------------------------------------------------------------------------------+
|      activo            |     no    |                      |   true                                  |
+-----------------------------------------------------------------------------------------------------+
|      bloqueado         |     no    |                      |   false                                 |
+-----------------------------------------------------------------------------------------------------+
|         idNodo         |     no    |                      |   f36a323c-3c20-42eb-811c-4e84668adade  |
+-----------------------------------------------------------------------------------------------------+
|   configuracionJson    |     sí    |        <nulo>        |                                         |
+-----------------------------------------------------------------------------------------------------+
|      tipoDeToken       |     no    |                      | numerico                                |
+-----------------------------------------------------------------------------------------------------+
| tokenMaximoCorrelativo |     no    |                      | 100                                     |
+-----------------------------------------------------------------------------------------------------+
|   ultimoTokenGenerado  |     sí    |        <nulo>        | 1                                       |
+-----------------------------------------------------------------------------------------------------+
|     prioridadVisual    |     no    |                      | alta                                    |
+-----------------------------------------------------------------------------------------------------+
```
el comando resultante sería:
```
curl -H "Content-Type: application/json" -i \
     -X POST http://ppi.cloudapp.net/api/adm/registrarservicio \
     -d "{ 'apiKey': 'a34287f8-102a-4cf3-bace-153c30c3eb58', \
           'id': '75e48afb-25dd-447a-a864-15992ec070b4', \
           'titulo': 'servicio de prueba', \
           'activo': 'true', \
           'bloqueado': 'false', \
           'idNodo': 'f36a323c-3c20-42eb-811c-4e84668adade', \
           'configuracionJson': '', \
           'tipoDeToken': 'numerico', \
           'tokenMaximoCorrelativo': '100', \
           'ultimoTokenGenerado': 1, \
           'prioridadVisual': 'alta' }"
```
* Para revisar los datos del servicio que registramos, podemos ejecutar:
```
curl -H "Content-Type: application/json" -i \
     -X POST http://ppi.cloudapp.net/api/adm/obtenerservicios \
     -d "{ 'apiKey': 'a34287f8-102a-4cf3-bace-153c30c3eb58', \
           'id': '75e48afb-25dd-447a-a864-15992ec070b4' }"
```
