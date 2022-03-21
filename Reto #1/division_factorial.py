def main():
    
    fact = int(input('Ingrese el numero al que desea sacar el factorial: '))
    primo = int(input('Ingrese el numero por el que desea dividir el factorial: '))


    if (fact and primo > 0) and (fact and primo < 2**31):
        
        def es_primo(numero):
            for i in range(numero):
                if numero % i == 0:
                    print(f"\n El numero ingresado no es primo tiene a {i} de divisor")
                    return False
                else:   
                    print(f"\n {numero} es primo")
                    return True

        respuesta = es_primo(primo)
        if(respuesta == True):

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

    elif (fact and primo > 2**31):
        print(f"N que es: {fact} & P que es: {primo}, son mayores al maximo permitido.")
    else:
        print("Fin.")


if __name__ == '__main__':
    main()