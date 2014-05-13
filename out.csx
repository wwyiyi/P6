	.text
	.globl main
main:		# METHOD ENTRY
__start:		# add __start label for main only
	sw    $ra, 0($sp)	#PUSH
	subu  $sp, $sp, 4
	sw    $fp, 0($sp)	#PUSH
	subu  $sp, $sp, 4
	addu  $fp, $sp, 20
	.data
.L0:	.asciiz"hi"
	.text
	la    $t0, .L0
	sw    $t0, 0($sp)	#PUSH
	subu  $sp, $sp, 4
	lw    $a0, 4($sp)	#POP
	addu  $sp, $sp, 4
	li    $v0, 4
	syscall
			#Assign
	li    $t0, 5
	sw    $t0, 0($sp)	#PUSH
	subu  $sp, $sp, 4
	move  $t0, $sp
	sw    $t0, -20($sp)
	lw    $t0, 4($sp)	#POP
	addu  $sp, $sp, 4
			#IdNode
	sw    $t0, -20($sp)
	sw    $t0, 0($sp)	#PUSH
	subu  $sp, $sp, 4
	lw    $a0, 4($sp)	#POP
	addu  $sp, $sp, 4
	li    $v0, 1
	syscall
_main_Exit:
	lw    $ra, -12($fp)
	move  $t0, $fp
	lw    $fp, -16($fp)
	move  $sp, $t0
	li    $v0, 10
	syscall
