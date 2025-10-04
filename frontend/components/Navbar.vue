<template>
  <header class="border-b border-primary/70 bg-primary/40 backdrop-blur sticky top-0 z-50">
    <div class="max-w-7xl mx-auto px-4 py-3 flex items-center justify-between">
      <NuxtLink to="/" class="flex items-center gap-2 font-semibold tracking-wide">
        <span class="inline-block w-2.5 h-2.5 rounded-full bg-accent"></span>
        KORTEXA
      </NuxtLink>
      <nav class="flex items-center gap-4 text-sm">
        <NuxtLink to="/dashboard" class="hover:text-accent">Dashboard</NuxtLink>
        <NuxtLink to="/perfil" class="hover:text-accent">Perfil</NuxtLink>
        <NuxtLink to="/admin" class="hover:text-accent">Admin</NuxtLink>
        <NuxtLink to="/login" class="px-3 py-1.5 rounded-lg bg-accent/20 hover:bg-accent/30">Iniciar sesión</NuxtLink>
      </nav>
    </div>
  </header>
</template>
