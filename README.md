# DIO - .NET Track - Object-Oriented Programming
www.dio.me

## Project Challenge
For this challenge, you will need to apply the knowledge you've gained from the object-oriented programming module in the .NET track at DIO.

## Context
"You are responsible for modeling a system that works with mobile phones. For this purpose, you have been asked to abstract a mobile phone and provide ways for different brands and models to have their own behavior, enabling greater code reuse and using object-oriented programming."

## Proposal
"You need to create a .NET console-based system, mapping an abstract class and specific classes for two types of mobile phones: Nokia and iPhone. You should create your classes according to the diagram below."

![Class diagram](Imagens/diagrama.png)

## Rules and validations
1. The class **Smartphone** must be abstract, preventing instantiation and serving only as a template.
2. The classes **Nokia** and Iphone must be child classes of Smartphone.
3. The **InstallApplication** method should be overridden in the Nokia and iPhone classes since they both have different ways of installing an application.

## Solution
The code is halfway done, and you should continue following the rules described above so that in the end, we have a functional program. Look for the commented word "TODO" in the code, then implement it according to the rules above.