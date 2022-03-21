def main():
    
    fact = int(input('Ingrese el numero al que desea sacar el factorial: '))
    primo = int(input('Ingrese el numero por el que desea dividir el factorial: '))


    if (fact and primo > 0) and (fact and primo < 2**31):
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

        def es_primo(numero):
            for n in range(2, numero):
                if numero % n == 0:
                    print(f"El numero ingresado no es primo tiene a {n} divisor")
                    return False
            print(f"{numero} es primo")
            return True

        print(f"Este numero {primo} es: ", es_primo(primo))

        
    else:
        print(f"N que es: {fact} & P que es: {primo}, no cumplen con lo establecido. ")

if __name__ == '__main__':
    main()