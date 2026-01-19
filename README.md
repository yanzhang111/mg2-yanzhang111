[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# MG2
## Devlog
I participated in the Week 2 breakdown activity, so before writing any code for MG2, I had already divided the game into three main parts: the player’s jump behavior, the coin behavior, and a GameController that handles scoring and spawning coins.In class, I planned for the player to only jump when on the ground. In Player.cs, I used an isGrounded boolean, put the jump input in Update(), and updated the grounded state in OnCollisionEnter2D() and OnCollisionExit2D(). This part matched my original breakdown almost exactly.


For the coins, my plan was that they would move left constantly and disappear when the player touches them. In Coin.cs, I used transform.Translate() to move the coins and OnTriggerEnter2D() to check for collision with the player, then called GameController’s AddPoint(). This followed the idea I wrote during the activity.In my breakdown, the GameController’s job was “manage score + spawn coins.” In GameController.cs, I used InvokeRepeating() to spawn coins over time, and updated the UI points text in AddPoint(). The only change I made outside the original plan was adjusting the random Y range in SpawnCoin() so coins wouldn’t generate too low for my specific scene layout.


Overall, the final scripts (Player.cs, Coin.cs, GameController.cs) followed the structure I planned during Week 2, with only a small adjustment for the coin spawn height after testing.


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites
