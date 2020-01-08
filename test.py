import matplotlib
import matplotlib.pyplot as plt
import numpy as np
 
dt = 0.1
m = 10
ky = 0.47
kz = 0.47
gx = 0
gy = -10
x0 = 0
y0 = 0
v0x = 1000
v0y = 1000


def xt(t):
    return x0+m/kx*((v0x-m*gx/kx)*(1-pow(np.e,-kx / m * t))+gx*t)
 
def yt(t):
    return y0+m/ky*((v0y-m*gy/ky)*(1-pow(np.e,-ky / m * t))+gy*t)
 
def vxt(t):
    return v0x * pow(np.e,-kx / m * t) - gx * m / kx * (1 - pow(np.e,-kx / m * t))
 
def vyt(t):
    return v0y * pow(np.e,-ky / m * t) + gy * m / ky * (1 - pow(np.e,-ky / m * t))

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
