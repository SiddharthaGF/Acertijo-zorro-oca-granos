using static Acertijo01.BaseConocimiento;

ResolverAcertijo acertijo = new();

var izq = "izquierda";
var der = "derecha";

acertijo.AnadirDireccion(izq, der);
acertijo.AnadirDireccion(der, izq);

acertijo.AnadirEstado(der, der, der, der);
acertijo.AnadirEstado(der, der, izq, izq);
acertijo.AnadirEstado(izq, der, izq, izq);
acertijo.AnadirEstado(der, der, izq, der);
acertijo.AnadirEstado(izq, izq, izq, der);
acertijo.AnadirEstado(der, izq, der, der);
acertijo.AnadirEstado(izq, der, izq, der);
acertijo.AnadirEstado(izq, izq, izq, izq);

acertijo.AnadirEstadoProhibido(izq, der, der, izq);
acertijo.AnadirEstadoProhibido(der, izq, izq, der);
acertijo.AnadirEstadoProhibido(izq, izq, der, der);
acertijo.AnadirEstadoProhibido(der, der, izq, izq);
acertijo.AnadirEstadoProhibido(der, izq, izq, izq);
acertijo.AnadirEstadoProhibido(izq, der, der, der);

Estado inicial = new(der, der, der, der);
Estado final = new(izq, izq, izq, izq);

acertijo.Resolver(inicial, final);
