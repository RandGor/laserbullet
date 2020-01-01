import matplotlib
import matplotlib.pyplot as plt
import numpy as np
 
dt = 0.1
m = 10
k = 0.47
gx = 0
gy = -10
x0 = 0
y0 = 0
v0x = 1000
v0y = 1000


def xt(t):
    return x0+m/k*((v0x-m*gx/k)*(1-pow(np.e,-k / m * t))+gx*t)
 
def yt(t):
    return y0+m/k*((v0y-m*gy/k)*(1-pow(np.e,-k / m * t))+gy*t)
 
def vxt(t):
    return v0x * pow(np.e,-k / m * t) - gx * m / k * (1 - pow(np.e,-k / m * t))
 
def vyt(t):
    return v0y * pow(np.e,-k / m * t) + gy * m / k * (1 - pow(np.e,-k / m * t))

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
