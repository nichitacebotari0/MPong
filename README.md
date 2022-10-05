Multiplayer Pong
Currently running at https://prodstacvwebsite.z6.web.core.windows.net/
TODO: 
- Host a website(angular+asp.net core) that will route to and serve the game.(currently hosted in azure storage static)
- Make deployment automatic(figure out godot automatic build and then use az cli to copy )
- Add actual over the wire multiplayer(look into WebRTC)
- make the game better: 
  *  Paddle reflection kind of meh
  * Ball speed too slow(make it increase with time?)
  * Investigate Pixel jitteryness on diagonal ball movement(its probably snapping to whole pixels)
  * Add effects(sound, maybe some particles, different player colors,etc)

