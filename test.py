import matplotlib
import matplotlib.pyplot as plt
import numpy as np
 
dt = 0.1
mx = 10
my = 10
k = 0.47
gx = 0
gy = -10
x0 = 0
y0 = 0
v0x = 1000
v0y = 1000


def xt(t):
    return x0+mx/k*((v0x-mx*gx/k)*(1-pow(np.e,-k / mx * t))+gx*t)
 
def yt(t):
    return y0+my/k*((v0y-my*gy/k)*(1-pow(np.e,-k / my * t))+gy*t)
 
def vxt(t):
    return v0x * pow(np.e,-k / mx * t) - gx * mx / k * (1 - pow(np.e,-k / mx * t))
 
def vyt(t):
    return v0y * pow(np.e,-k / my * t) + gy * my / k * (1 - pow(np.e,-k / my * t))

x = []
y = []

ddt = np.arange(0.0, 200.0, dt)
for i in ddt:
    x.append(xt(i))
    y.append(yt(i))

fig, ax = plt.subplots()
ax.plot(x,y)
ax.set(xlabel='x (m)', ylabel='y (m)',
       title='About x(t), y(t)')
ax.grid()
 
plt.show()
