def main():
    
    n = int(input('Ingrese un numero de rondas que desea en el torneo: '))

    if n > 0 and n <= 20:
        
        torneo = []
        participantes = 2**n
        print(f"\nEl número de jugadores que hay en el torneo es de: {participantes}")
    
        for i in range(participantes):
            torneo.append(i+1)

        print(f"\tEste es el orden de participantes: {torneo}")

        player1 = int(input("\n\tIngrese el número de serie del Primer jugador: "))
        player2 = int(input("\tIngrese el número de serie del Segundo jugador: "))

        if((1 <= player1 <= 2**participantes) and ((1 <= player2 <= 2**participantes) and player1 != player2)):
            round = 0
            p1 = player1 - 1
            p2 = player2 - 1

            while p1 != p2:
                p1 >>= 1
                p2 >>= 1
                round += 1

            print(f"\nLos jugadores {player1} y {player2} se enfrentaran en la ronda: {round}")

        elif((1 <= player1 <= 2**participantes) and ((1 <= player2 <= 2**participantes) and player1 == player2)):
            print("\nLos jugadores para enfrentar son los mismos")
            print("Fin.")
        else:
            print("\nAlguno de los números de serie ingresado, no se encuentra entre el rango de jugadores")
            print("Fin.")

    elif n > 20:
        print(f"\nEl numero ingresado {n} es mayor que lo permitido que es 20.")
    else:
        print(f"\nEl numero ingresado {n} es menor que lo permitido que es 1.")

if __name__ == '__main__':
    main()