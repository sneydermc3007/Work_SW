def main():
    torneo = []
    participantes = int(input('Ingrese un numero: '))

    if participantes > 0 and participantes <= 20:

        participantes = 2**participantes
        print(f"\nEl numero de participantes que hay en el torneo es de: {participantes}")
    
        for i in range(participantes):
            torneo.append(i+1)

        print(f"\nEste es el orden de participantes: {torneo}")
        player1 = int(input("\tIngrese el primer jugador del enfrentamiento: "))
        player2 = int(input("\tIngrese el otro jugador con el que se va a enfrentar: "))

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
            print("\nUno o ambos jugadores no estan inscritos en el torneo")
            print("Fin.")

    elif participantes > 20:
        print(f"\nEl numero ingresado {participantes} es mayor que lo permitido.")
    else:
        print(f"\nEl numero ingresado {participantes} es menor que lo permitido.")

if __name__ == '__main__':
    main()