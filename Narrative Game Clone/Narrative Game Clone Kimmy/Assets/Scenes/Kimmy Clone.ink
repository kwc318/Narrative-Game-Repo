VAR money = 0.25
VAR rscore = 0
VAR ropec = 0.04
VAR frisbeec = 0.05
VAR dicec = 0.04
VAR ballc = 0.03
VAR chalkc = 0.06
VAR pencilandpaper = 0.03

Returning home after picking up Kimmy, you converse with your mother

+ [Mom! Look! God sent me a baby!]
-> Mom1

= Mom1
Mom:			...Excuse me? #mom #2 #3    
Dana:			Her name is Kimmy!#Dana
Kimmy:			... #Kimmy
Mom:			That… No, Dana. God did not send you a baby. #mom
Dana:			What do you mean…? You said God sends people babies sometimes! You told me that.
Mom:			Well… nevermind what I said. It doesn’t apply to you. God isn’t about to send you a baby anytime soon, trust me. #mom
Dana:			What! Why? I wished for a baby, and he granted my wish. Isn’t it obvious?
Mom:			Where did you find this little girl? Honey, where’s your house? #mom
Kimmy:			...
Mom:			Kimmy, can you tell me where your parents are? #mom
Kimmy:			I can go home later if I want…
Dana:			Well maybe God didn’t send her, but she came out of nowhere! Kimmy, you just… appeared, right? Where did you come from?
Kimmy:			Ferry Street... I untied myself from the porch so I could go for a walk…
Dana:			...
Mom:			It’s ok dear, let’s go to your house Kimmy… you said it’s on Ferry Street? Your parents are probably worried. #mom

+ [Drop Kimmy off at her house]
-> returnhome

= returnhome
Dana:			I’m sorry… I thought God sent me a baby and I got so excited…
KimmyMom:			Oh, don’t worry. Thank you for finding Kimmy and walking her home. What's your name, dear?
Dana:			I’m Dana…
KimmyMom:			I don’t know many kids as responsible as you, walking Kimmy all the way home. I hope you two can be friends. I know Kimmy could learn a lot from you.
Kimmy:			My… friend?
Dana:			Yes! I’d love to be friends, Kimmy. Can I come by and play with you tomorrow?
KimmyMom:			I’ve been looking for a babysitter, actually. Her grandma was helping with that before, but she… well, she can’t anymore.
KimmyMom:			Kimmy’s normally alright in her harness on the porch, but she’s getting a little old for that…
KimmyMom:			If you’d like to play with Kimmy tomorrow, I’d be happy to pay you a quarter to keep an eye on her.
+ [Wow! Yes, please! I’d love to!]
-> yes

= yes
KimmyMom:			My work schedule is a little… hectic. It’d be great to have you by in the morning.
Dana:			I’ll be here first thing! Wow, I didn’t expect to land a job today. Thanks so much!
Mom:			Well, that all sounds good to me. A summer job will be a nice way to keep busy. Now then, let’s leave this nice family to their dinner.
Dana:			Ok. Bye bye Kimmy, and Mrs...?
KimmyMom:			Mrs. Munro. Again, thank you for giving Kimmy a hand. It was nice meeting you, Mrs. Navarro.
Mom:			Likewise.
Kimmy:			Bye bye.

+ [Leave Kimmy's house]
-> leave

=leave
You return home to a peaceful night of rest. The next morning, your return to Kimmy's house and begin your new job as her babysitter.

+ [Go to Kimmy's house]
-> choices

= choices
You think about where to go next

+ [Go home]
->home
+ [Go to Kimmy's house]
-> Khouse
+ [Go downtown]
-> downtown
+ [Go to playground]
-> playground

= Khouse
You are standing outside Kimmy's house.

+ [Go to store]
-> store
+ {not success}[Talk to Donna]
-> donna
+ [Back to map]
-> choices

=store

{store == 1: -> clerk }

The store has a wonderful selection of toys
Money = ${money}
{rope == 0:Rope = ${ropec}}
{frisbee == 0:Frisbee = ${frisbeec}}
{dice == 0:Dice = ${dicec}}
{ball == 0:Ball = ${ballc}}
{chalk == 0:Chalk = ${chalkc}}

+ {not rope}[Buy rope]
-> rope

+ {not frisbee}[Buy frisbee]
-> frisbee

+ {not dice}[Buy dice]
-> dice

+ {not ball}[Buy ball]
-> ball

+ {not chalk}[Buy chalk]
-> chalk

+ [Leave]
-> leavedean

=clerk
Dean:			Hey, Kid.
Dana:			Hi, Dean. This is Kimmy. I’m babysitting her now.
Dean:			Well lookit that, aren’t you all grown up. You gettin’ paid?
Kimmy:			My mom pays Dana a quarter a day.
Dana:			That’s right! I’m here to buy some things… I mean, I haven’t gotten paid yet. This is my first day. But I have some money saved up!
Dean:			Hah, I wish I had that kinda discipline. I blew my budget on fabric last week.
Dana:			I need to save up money. For college, you know! My mom would get so mad if I didn’t plan ahead.
Dean:			Hah! Your mom’s got the right idea. I wish I’d saved up for college.
Dana:			So what did you spend all your money on? Your sewing classes?
Dean:			Nah, that’s over. I’m workin’ on some Halloween costumes for my cousins… and some new pants for myself. You know, gotta apply those skills somehow.
Kimmy:			I didn’t know people made clothes!
Dean:			They do, Kimmy, they do. I make sweaters, dresses, hats--you name it.
Dana:			You should sell your clothes at Jordan Marsh! That’s where I always find the nicest clothes.
Dean:			Hah! That’s a long ways off for me. But maybe someday… anyways, what can I get for ya?

+ [Look around]
->store

=rope
You bought the rope

~money -= ropec

-> store

=frisbee
You bought the frisbee

~money -= frisbeec

-> store

=dice
You bought the dice

~money -= dicec

-> store

=ball
You bought the ball

~money -= ballc

-> store

=chalk
You bought the chalk

~money -= chalkc

-> store

=leavedean

Dana:			Thanks, Dean!
Kimmy:			Thank you Mr. Dean!
Dean:			Bye bye girls. Have fun.

-> Khouse

= donna
Kimmy:			Hi Donna.
Donna:			What happened, Kimmy? Did you untie yourself from the porch again?
Kimmy:			...
Dana:			Hi Donna! I’m babysitting Kimmy now, so--
Donna:			So you untied Kimmy from the porch? Better not let her parents catch you.
Dana:			First of all, I’m her babysitter. Second, she’s perfectly able to untie herself. She’s too old for that thing now, even her mom thinks so.
Donna:			She should probably stay on her porch. We’re the same age, but my mom takes me everywhere so I won’t get lost. I bet Kimmy would get lost if she wandered too far.
Dana:			I don’t know about that. Anyways, I was just going to ask if you wanna play with us... but I feel like you're being mean to Kimmy.
Donna:			Oh, no. I'm just being honest!
Dana:			Ok... well, I hope you two can get along, since you're neighbors... want to play a game with us?
Donna:			Well, I’m trying to avoid Harold so it’s probably good to look busy. He keeps trying to tell me that my ears look childish. He is so snobby.
Kimmy:			I like your ears.
Donna:			Oh, thanks. They’re new. Anyways, I wanna play a new game.

+ {not rope}[Play game]
-> nogame

+ {rope}[Play game]
-> game

=nogame
Dana:			Oh no! I’m sorry… I thought I had some stuff to play games with in my bag… but it looks like I ran out.
Kimmy:			Oh no...
Dana:			It’s ok! Kimmy, let’s run to the store and buy some game pieces! We’ll be right back!

->Khouse

=game
Donna:			Ok, let's try tug-of-war then.

+ Ok, I'll teach you how to play tug-of-war.
-> rdchoices1

=rdchoices1

+ You need a rope and a staircase.
-> rdchoices2

+ You need a rope and a ribbon.
~rscore += 1
-> rdchoices2

+ You need a rope and puddles.
-> rdchoices2

=rdchoices2

+ Then, you each hold one end of the rope on the different side of the puddle.
-> rdchoices3

+ Then, you each hold one end of the rope, one at the top of the stairs and one at the bottom.
-> rdchoices3

+ Then, tie a ribbon around the the middle of the rope, and mark the ground with two parallel goal lines.
~rscore += 1
-> rdchoices3

=rdchoices3

+ Now you each hold one end of the rope, and tug as hard as you can.
~rscore += 1
-> rdchoices4

+ Now, you try to pull each other into the puddle using the rope.
-> rdchoices4

+ Now, the friend at the bottom of the stairs ties the rope around their waist.
-> rdchoices4

=rdchoices4

+ you win if you can pull the rope's ribbon across your side, where the marking closest to you.
~rscore += 1
-> rdchoices5

+ you win if you can pull the other friend to the top of the stairs using the rope.
-> rdchoices5

+ you win if you can pull your friend into the puddle.
-> rdchoices5

=rdchoices5

{rscore == 4: -> success }

{~That doesn't sound right...|That sounds wrong, but ok!|Really? Are you sure you know how to play?}

~rscore = 0

->game

= success
{~Ok, that makes sense!|Sure!|Sounds right to me!}

+ [One hour later...]
->dhappy

=dhappy
Donna:			Kimmy loved that.
Donna:			I’m surprised, normally you’re so quiet Kimmy.
Kimmy:			Mom said it’s ok to be quiet.
Dana:			That’s right! Games are a nice way to talk and play with your friends though, don’t you think? Even quiet kids like games, I think, usually.
Kimmy:			… Are we friends? I thought you were my babysitter.
Dana:			Yes! Of course we’re friends! I know we just met yesterday, but… that’s normal!
Kimmy:			I always thought babysitters were more like parents.
Dana:			I can be your friend AND your babysitter. We’re having fun playing games together, right? That’s what friends do a lot of the time.
Dana:			Anthony and I became friends by playing games together. We met playing kickball.
Donna:			Anthony and his little sister Amber are… annoying. Don’t tell them I said that though…
Dana:			Really? Anthony and I go to the same school and do sports together sometimes. He’s way nicer than the other boys at my school. I like him and Amber.
Donna:			There’s no rule that says you have to like your classmates.

+ [Yeah, I know… but Anthony is nice to me, so I like him.]
->like

=like
Donna:			Oooh, you like... Like him?
Dana:			…I’m not going to answer that, Donna. Who I like is none of your business.
Donna:			...Are you gonna walk to Jordan Marsh? That’s where my babysitter used to take me.
Dana:			Maybe! Kimmy doesn't seem to know too many people around town though, so I think we should save big trips for later.
Donna:			Playing is fine, but isn’t it boring sometimes? I need more friends  who will go with me to Jordan Marsh. I like going shopping there. I hide in the clothes racks sometimes.
Kimmy:			Dad took me there once. He needed a new leather jacket. But then he bought another new guitar and mom got mad when we came home.

+ [Haha, your dad is so weird.]
->weird

=weird
Donna:			I don’t see your dad around much anymore, but I guess that’s because I’m not out on the porch like I used to be.
Kimmy:			Donna used to be in a harness outside, like me.
Donna:			Yeah I used to wear a harness attached to the front door when my mom was cooking or doing laundry. It was so embarrassing.
Donna:			My mom said I’m too big for the harness. I go bike riding a lot now. I went by myself to Jordan Marsh yesterday and got these ears…
Kimmy:			I like them.
Dana:			I like riding my bike to Jordan Marsh too! Sometimes I’ll buy a ribbon if I save up.
Kimmy:			I’ve never worn a ribbon.
Dana:			Wow! Really? I can get you one, Kimmy, don’t worry.
Kimmy:			No thank you, I’m not supposed to spend any money. I don’t have any anyways.
Dana:			I’ll save up and get you one!
Donna:			Kimmy, you would look nice in a ribbon. Cat ears too probably.
Kimmy:			…Maybe.

+ [Leave Donna]
->endgame

=endgame
Dana:			Wasn't that fun, Kimmy!
Kimmy:			Y-yes…
Dana:			I think this deserves a sticker. You did a good job! We're gonna keep making you lots of friends...!

+ [1 hour later...]
->END


= home
You are standing outside your house.

+ [Back to map]
-> choices

= downtown
You are downtown.

+ [Back to map]
-> choices


= playground
you are at the playground.

+ [Back to map]
-> choices  

->DONE                                                                              