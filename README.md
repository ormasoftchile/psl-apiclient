#psl-apiclient
Biblioteca .NET que permite acceder a los servicios de la API Pasamonte Labs.
Encapsula invocaciones REST a través de una biblioteca de clases, facilitando realizar la integración con los servicios.

##Los servicios disponibles se enmarcan en dos categorías:

### Integración con Registro Clínico Electrónico (RCE). (Actualmente se implementa la interoperabilidad con la plataforma SAYDEX).
* Validación de usuarios (pacientes) en plataforma RCE.
* Obtención de recetas con despachos pendientes desde RCE.
* Registro (notificación) de despachos realizados a RCE.

###Integración con operaciones de
* Citas médicas
* Administración de turnos

###Métodos de la interfaz
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

###Vea la documentación de los objetos en
http://pasamonte.github.io/docs/psl-apiclient
