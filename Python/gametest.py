#Import de Biblioteca
import pygame

#Configurações do Display e jogo
pygame.init()
screen = pygame.display.set_mode((1280, 720))
clock = pygame.time.Clock()
running = True
dt = 0

player_pos = pygame.Vector2(screen.get_width() / 2, screen.get_height() / 2)

while running:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            running = False

    #Cor da tela e na opção pygame seta as configações de teclado
    screen.fill("white")

    pygame.draw.circle(screen, "black", player_pos, 40)

    teclas = pygame.key.get_pressed()
    if teclas[pygame.K_w]:
        player_pos.y -= 300 * dt
    if teclas[pygame.K_s]:
        player_pos.y += 300 * dt
    if teclas[pygame.K_a]:
        player_pos.x -= 300 * dt
    if teclas[pygame.K_d]:
        player_pos.x += 300 * dt

    pygame.display.flip()
    dt = clock.tick(60) / 1000

pygame.quit()
