#include <stdio.h>
#include <stdlib.h>
#include <time.h>

void playGame() {
    int randomNumber, userGuess, attempts = 0;

    // Seed random number generator
    srand(time(0));
    randomNumber = rand() % 100 + 1;  // Random number between 1 and 100

    printf("🎯 Welcome to the Number Guessing Game!\n");
    printf("I've picked a number between 1 and 100. Can you guess it?\n");

    // Loop until the user guesses correctly
    do {
        printf("Enter your guess: ");
        scanf("%d", &userGuess);
        attempts++;

        if (userGuess > randomNumber) {
            printf("Too high! Try again.\n");
        } else if (userGuess < randomNumber) {
            printf("Too low! Try again.\n");
        } else {
            printf("🎉 Congratulations! You guessed the number in %d attempts.\n", attempts);
        }
    } while (userGuess != randomNumber);
}

int main() {
    playGame();
    return 0;
}
