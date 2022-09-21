Multiplayer Pong
Currently running at https://prodstacvwebsite.z6.web.core.windows.net/
TODO: 
1) Host a website(angular+asp.net core) that will route to and serve the game.(currently hosted in azure storage static)
2) Make deployment automatic(figure out godot automatic build and then use az cli to copy )
3) Add actual over the wire multiplayer(look into WebRTC)
4) make the game better: 
  I.  Paddle reflection kind of meh
  II. Ball speed too slow(make it increase with time?)
  III.Investigate Pixel jitteryness on diagonal ball movement(its probably snapping to whole pixels)
  IV. Add effects(sound, maybe some particles, different player colors,etc)

