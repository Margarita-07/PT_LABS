using System;
using OOP_RATIONAL;

// Используем инициализатор для задания значений полям после создания объекта
Rational r1 = new Rational(3, 4);

Rational r2 = new Rational(-2, 0);

Rational r3 = new Rational(4);
r3.Denominator = 0;

Console.WriteLine(r1);
Console.WriteLine(r2);
Console.WriteLine(r3);

