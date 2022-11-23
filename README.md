# VB-Uno
Uno created in Visual Basic

The game of Uno contains 108 cards varying between different colors of Red, Green, Blue and Yellow.

Each of these colors contains number cards and specialized cards, including the skip, reverse, and plus two cards. There are also wild cards and plus four wild cards that allow for the selection of any of the previously mentioned colors. 

The goal of the game is to be the first to place all of the cards in your deck. 

Your deck is visually represented at the bottom of the screen, only showing 6 cards in your hand at a time. To see the other cards, a scroll bar is above your deck that can be moved to reveal the other cards in your deck.

To place a card, you need to click on the card in your deck and then click on the top card of the pile. If you don’t have any available cards, you need to click on the Uno card to the left of the pile to draw a card. 

When you have placed your second to last card, you have 5 seconds before the computer makes it’s turn to click the Uno play button to say uno or you will receive a two card penalty.


This project is a recreation of the card game Uno in Visual Basic, playing against the computer with varying levels of difficulty.
______________________________________________________________________________________________________________________

Challenges:
1. How to create various difficulties
I decided to create just one difficulty due of time.

2. How to create a playable AI
I created a timer that repetitively checked if it was the computer's turn. If it was the computer's turn, it checked to see if any of the cards in the computer's deck were compatible with the top card on the pile. If so, it randomly chose a possible card. If not, it drew a card from the deck.

3. How to create a deck of cards
The deck is represented as a listbox, with each card in the deck being represented as an item in the list. Each deck of cards is generated when the game starts by randomly selecting 7 cards from the pile.

4. How to visually represent the cards
Each card is represented by a label box which changes background color to the card color, and changes the text to the type of card the label is representing.

5. How to implement the specialized cards
The specialized cards are added with specific code for every card rather than just a generic number card code. With each special card being individually checked, specific actions like adding cards to an opponent's deck or skipping an opponents turn can be added directly in the check statement.
