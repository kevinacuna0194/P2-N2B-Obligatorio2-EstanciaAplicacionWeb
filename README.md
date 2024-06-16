# Obligatorio 2 Programación 2 :bookmark_tabs:
~~~
Continuando el sistema realizado para el primer obligatorio, nuestro cliente nos pide desarrollar una segunda 
versión que incluya una aplicación Web ASP.NET 8.0 MVC con acceso mediante usuario y contraseña. Cuando el 
usuario ingresa al sistema, será posible visualizar determinadas opciones dependiendo del rol que posea. Se debe 
verificar que un usuario que no esté autenticado o no tenga permisos, no pueda acceder a las funcionalidades 
que no le corresponden. No podrá visualizar las opciones de menú ni acceder a ellas si ingresa a través de la URL 
correspondiente.  
Se pide:  
Punto 1:   
• Diagrama de clases del Dominio definitivo en el estándar UML (EN FORMATO ASTAH E INCLUIDO 
TAMBIÉN EN LA DOCUMENTACIÓN DIGITAL).   
• Diagrama de casos de Uso (EN FORMATO ASTAH E INCLUIDO TAMBIÉN EN LA DOCUMENTACIÓN 
DIGITAL).   
Página 1 de 4 
Computación - Electrónica - Telecomunicaciones - Sistemas de Información 
Facultad de Ingeniería 
Bernard Wand-Polak 
Cuareim 1451 
11.100  Montevideo, Uruguay 
Tel. 2902 15 05 Fax 2908 13 70 
www.ort.edu.uy 
Punto 2:   
Implementación en ASP.NET 8.0 / MVC con C#, utilizando Visual Studio 2022, de los siguientes ítems 
dependiendo del rol del usuario:  
Usuario anónimo  
• Login. Ingresará email y contraseña y en caso de que sean válidos quedará autorizado a 
acceder a las funcionalidades correspondientes a su rol.  
• Registrarse como peón. Ingresa su email y una contraseña, el nombre, y si es residente o no. El 
email y contraseña serán utilizados para verificar su identidad para ingresar con el rol “Peón”.  
Usuario Peón  
• Acceder a sus datos personales  
• Registrar nueva vacunación para cualquier animal  
• Ver el listado de todas sus tareas aún no completadas ordenadas por fecha pactada 
ascendente. Se deben mostrar todos los datos de la tarea.  
• Completar una tarea pendiente. Cuando se completa una tarea se debe agregar un comentario 
de cierre.  
• Logout  
Usuario Capataz  
• Registrar un nuevo bovino en el sistema.  
• Asignar un animal libre a un potrero.   
• Ver listado de todos los peones. Se deben mostrar todos sus datos. Se podrá acceder a un 
detalle de todas las tareas que le han sido asignadas (completas o no)  
• Asignar una nueva tarea a un peón.  
• Ver listado de todos los potreros ordenados por capacidad ascendente y cantidad de animales 
descendente. Se debe mostrar el Identificador, la descripción, la cantidad de animales que 
contiene y el potencial precio de venta.  
• Dado un peso y un tipo mostrar todos los animales de ese tipo que superen el peso dado. De 
cada animal se debe mostrar el identificador de la caravana, el tipo de animal, el peso, sexo y la 
potencial ganancia de venta individual.  
• Logout  
Punto 3:   
Deploy del proyecto en Somee.  
Página 2 de 4 
Computación - Electrónica - Telecomunicaciones - Sistemas de Información 
Facultad de Ingeniería 
Bernard Wand-Polak 
Cuareim 1451 
11.100  Montevideo, Uruguay 
Tel. 2902 15 05 Fax 2908 13 70 
www.ort.edu.uy 
Punto 4:  
Documentación en PDF:  
• Portada en la que consten Número, Nombre y Apellido de cada integrante del equipo de 
obligatorio, grupo al que está inscripto, docente del grupo y foto de cada integrante del equipo.  
• Diagrama de clases definitivo del Dominio del problema.  
• Diagrama de casos de uso que incluya todas las funcionalidades solicitadas.  
• Una planilla con los casos de prueba necesarios para probar la totalidad de la aplicación y 
evidenciar el testing.  
• Código fuente COMENTADO de toda la aplicación. Solamente se incluirá el código fuente de las 
clases del dominio. Se deberán incluir los comentarios que considere relevantes.  
• La documentación solicitada se entregará en un ÚNICO documento en formato PDF. Se 
incluirán los ajustes y mejoras a la primera entrega (si corresponde)  
Importante  
Para esta segunda entrega, la interfaz de usuario se realizará utilizando un proyecto ASP.NET/MVC y para la 
lógica de negocio se debe utilizar un proyecto biblioteca de clases.  
Los requerimientos de la aplicación pueden sufrir ajustes durante el periodo de desarrollo que el docente 
informará oportunamente a través del Foro de Aulas y será responsabilidad del estudiante mantenerse 
informado.  
• Se deberán incluir las validaciones que correspondan durante los ingresos para garantizar la 
consistencia del sistema, como así mostrar mensajes de error adecuados pensando en la 
experiencia del usuario.   
• Se recomienda incluir comentarios al código para comprensión de la lógica más importante.  
• Se debe incluir una precarga de datos de toda la información necesaria que permita probar y 
cubrir los requerimientos solicitados en la entrega  
ENTREGA:  
Se deberá subir a gestión un único archivo comprimido que incluya lo siguiente:  
• La solución .NET 8 completa con la implementación de todos los requerimientos anteriores 
funcionando a través de una aplicación Web MVC ASP.NET 8 y las bibliotecas de clase 
correspondientes (.NET 8).  
• El documento PDF con la documentación anteriormente indicada.  
• El archivo Astah con el/los diagrama/s del diseño de la aplicación y el diagrama de Casos de 
Uso 
~~~
---
<p align="center" font-weight="bold">
      <img src="https://img.shields.io/badge/CSHARP-239120?style=for-the-badge&logo=csharp&logoColor=white">
      <br>
      <img src="https://img.shields.io/badge/ESTADO-EN%20DESARROLLO-blue?logo=csharp&logoColor=violet&logoSize=10px">
</p>