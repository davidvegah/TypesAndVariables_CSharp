// Boolean | 1 bit. Se puede asignar (solo poner bool active) y luego reasignarlo (con active = true/false).
bool active;
active = true;
active = false;

// Byte | 8 bit | 0 to 255.
byte angles = 100;

// Character | 16 bit. Es como lo opuesto de un String, ya que no es una cadena, es solo un caracter y utiliza comillas simples.
char initial = 'E';

// Short | 16 bit | -32 768 to 32 767
short lenght = 20000;

// Integer | 32 bit | -2,147,483,648 to 2,147,483,647.
int year = 2023;

// Float | 32 bit | ±1.5e−45 to ±3.4e38, 7 digits precision. Es para numeros muy pequeños. La F al final es necesaria.
float microDistance = 0.6568459684F;

// Double | 64 bit | 5.0e−324 to ±1.7e308, 15-16 digits precision . Se utiliza para poner decimales. Si aparece como "99.99D" no es un error, indica que es un double pero es opcional.
double grade = 99.99;

// Long | 64 bit | -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 | 
long distance = 500000000;

// Decimal | 128 bit | ±1.0 x 10^-28 to ±7.9 x 10^28, 28-29 digits precision.
decimal measurement = 1.654689468532413854565M;

// String | Dynamic size, es una cadena de caracteres, puede tener muchas o pocas palabras.
string name = "David Vega";