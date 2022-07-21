# Challenge ****Sat.Recruitment****
* Por Sebastián Gariglio
* Argentina
* Recibido: 20/07/2022 22:00
* Fecha: 21/07/2022 16:30

# Relevamiento
* Encontramos una aplicación con características REST; BackEnd en C#.
* El controlador principal expresa la intención de recibir un usuario con la finalidad de crearlo. 
* Cualidades principales de este proceso: 
* Verifica los datos de entrada
* Cataloga el usuario según su tipo y ajusta su campo money
* Verifica con base al archivo User.txt que el usuario no este duplicado bajo diferentes criterios
* Devuelve mensaje más un boolean correspondiente a si tuvo o no exito

# Trabajo realizado
* El proyecto a sido separado en capas: Proyecto princial, libreria y testing. 
* Hemos aplicado los principios SOLID, DRY y de refactorización para conseguir una aplicación escable y facilitar su mantenimiento
* Implementación de interfaces
* Presentamos clases Factory para centralizar la creación de los principales objetos intervenientes. Solucionando el problema de tener instanciaciones a lo largo del proyecto que pueda traernos inconvenientes a futuro.
* Los diferentes tipo de usuarios, con sus respectivos calculos han sido consolidados dentro sus correspondientes clases, con una interfaz comun. Beneficios Open/Close.
* El trabajo realizado expresa la intención de solución, pudiendose ser factible adentrarse aún más su desarrollo
* La validación del usuario la hemos consolidado dentro de una clase UserValidationEngine. De ser necesario nuevas validaciones, puede trabajarse aisladamente en esta clase. 
* Pruebas unitarias tanto para probar funcionalidad del Controlador (usuario creado, usuario duplicado)
* Pruebas unitarias para probar los distintos tipos usuarios (Normal, SuperUser, Premium)
* Las soluciones presentadas revelan la intención de solución. Es posible seguir desarrollando la solución.

# Agradecimientos
* Agradezco la oportunidad otorgada de realizar la prueba Sat.Recruiment. 
* He encontrado el desafio muy interesante debedio a la libertad de acción. 
* Estaria encantado de trabajar en un entorno que siga desafiendo mis conceptos de código prolijo, reutilizable y legible. 

# Contacto
* sebastian.gariglio@gmail.com
