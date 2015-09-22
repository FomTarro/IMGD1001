# You can place the script of your game in this file.

# Declare images below this line, using the image statement.
# eg. image eileen happy = "eileen_happy.png"

init -1:
    
   $ style.mm_root_window.background = "bg_3.png"
   # image bg_ceiling = "game/images/Backgrounds/bg_3.png",
    
    
# Declare characters used by this game.
define e = Character('Eileen', color="#c8ffc8")



    
# The game starts here.
label start:
    
    #scene bg_ceiling
    
    e "You've created a new Ren'Py game."

    e "Once you add a story, pictures, and music, you can release it to the world!"

    return
