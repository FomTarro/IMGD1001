# You can place the script of your game in this file.

# Declare images below this line, using the image statement.
# eg. image eileen happy = "eileen_happy.png"
    
image bg3 = "images/Backgrounds/bg_3.png"

image sl_idle scale = im.Scale("images/Character/ch_lead.png", 200, 400)

image hwirelogo fixed = Fixed(Image(im.Scale("images/Misc/ui_logo.png", 400, 200), xalign=0.0, yalign=0.0))
    
    
# Declare characters used by this game.
define sl = Character('Scientist', color="#c8ffc8")


# The game starts here.
label start:
    
    scene bg3
    
    show hwirelogo fixed
    
    sl "You've created a new Ren'Py game."

    sl "Once you add a story, pictures, and music, you can release it to the world!"

    return
