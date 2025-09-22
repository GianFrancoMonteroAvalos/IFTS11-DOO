# IFTS11 – Desarrollo de Sistemas Orientados a Objetos
**2° Cuatrimestre 2025**  
Docente: **Muñoz Lautaro Gabriel**  
Alumno: **Gian Franco Montero Avalos**

---

## 📚 Descripción
Este repositorio contiene la resolución de una serie de ejercicios prácticos de la materia **Desarrollo de Sistemas Orientados a Objetos (DOO)**.  
Se incluyen los ejercicios del **1 al 5** y el **Ejercicio Integral**, donde se aplican conceptos de **herencia, polimorfismo, arreglos y POO en C#**.

---

## 📂 Estructura
- [`ejercicio-01`](./ejercicio-01) → Arreglos de coordenadas.  
- [`ejercicio-02`](./ejercicio-02) → Vehículos con herencia (Auto, Moto, Camioneta).  
- [`ejercicio-03`](./ejercicio-03) → Persona con constructores sobrecargados.  
- [`ejercicio-04`](./ejercicio-04) → Equipo con Integrante, Jugador y Técnico.  
- [`ejercicio-05`](./ejercicio-05) → Pokedex con polimorfismo.  
- [`ejercicio-integral`](./ejercicio-integral) → Administración de máquinas virtuales en la nube.  

---

## 📝 Consigna del Ejercicio Integral
Se requiere de un desarrollo que nos ayude a administrar nuestras **instancias de computadores virtuales en la nube**.  

### 🔹 Información a almacenar
- Nombre  
- Versión  
- Sistema operativo  
- Estado (levantar = `up`, bajar = `down`)  

### 🔹 Clasificación de instancias
1. **De proceso de datos**  
   - Permiten realizar procesos como clonar bases de datos, filtrarlas y almacenarlas en otra.  
   - Información adicional a almacenar:  
     - Datos de origen  
     - Datos de fin  
   - Al levantarse (`up`), deben confirmar que poseen acceso correcto a datos de origen y destino.  
   - Mensaje esperado: instancia levantada correctamente con acceso a datos de origen y de fin.  

2. **De aplicación**  
   - Son la base para las aplicaciones que los desarrolladores deseen implementar o publicar.  
   - Información adicional a almacenar:  
     - Lenguaje de programación  
     - Versión del lenguaje  
     - Base de datos (URL o ubicación)  
   - Al levantarse (`up`), deben confirmar que:  
     - Se instaló el lenguaje con la versión especificada.  
     - Se posee acceso correcto a la base de datos.  

### 🔹 Requerimientos finales
- Instanciar **al menos dos máquinas virtuales de cada tipo** dentro de un arreglo.  
- Deben poder **levantarse y bajarse en simultáneo**.  
- Cada clase debe realizar su proceso almacenado de manera independiente.

  
