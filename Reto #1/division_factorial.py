def main():

    def es_primo(numero):
        if (numero == 1) or (numero == 2):
            return True
        else:
            for i in range(2, numero):
                if (numero % i) == 0:
                    print(f"\n El numero ingresado no es primo tiene a {i} de divisor")
                    return False
                else:
                    return True

    def factorial(numero):
        if numero == 0:
            return 1
        else:
            resultado = 1
            while (numero > 1):
                resultado *= numero
                numero -= 1
            return resultado
    
    primo = int(input("Ingrese el numero por el que desea dividir el factorial: "))
    fact = int(input("Ingrese el numero del que desea conocer el factorial: "))

    if (fact and primo > 0):
        is_not_primo = not es_primo(primo)

<<<<<<< HEAD
        while is_not_primo:
            primo = int(input("Vuelva a intentar con nuevo numero para dividir el factorial: "))
            is_not_primo = not es_primo(primo)

        if fact < 2**31 and primo < 2**31:
            resultado = factorial(fact)
            if (resultado %  primo)== 0:
                print("YES")
            else:
                print("NO")
        else:
            print(f"N que es: {fact} & P que es: {primo}, son mayores al maximo permitido.")
=======
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
>>>>>>> master
    else:
        print("Fin.")


if __name__ == '__main__':
    main()