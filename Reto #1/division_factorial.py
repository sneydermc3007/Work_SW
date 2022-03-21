def main():
    
    fact = int(input('Ingrese el numero al que desea sacar el factorial: '))

    if fact < 2**31:
        def factorial(numero):

            if numero < 0:
                return("no exite ya que es numero negativo")
            elif numero == 0:
                return 1
            else:
                resultado = 1
                while (numero > 1):
                    resultado *= numero
                    numero -= 1
                return resultado

        print(f"El factorial de {fact} es: ", factorial(fact))
    
    else:
        print(f"El numero {fact} es mayor que lo permitido. ")

if __name__ == '__main__':
    main()