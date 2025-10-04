<script setup lang="ts">
definePageMeta({ layout: 'public' })
</script>

<template>
  <section class="w-full max-w-4xl text-center space-y-6">
    <div class="space-y-2">
      <h1 class="text-4xl md:text-5xl font-bold tracking-tight">
        KORTEXA
      </h1>
      <p class="opacity-80">
        Plataforma de análisis léxico multilenguaje.
      </p>
    </div>

    <div class="flex items-center justify-center gap-3">
      <NuxtLink to="/login" class="px-5 py-2 rounded-xl bg-accent/80 hover:bg-accent/90">
        Iniciar sesión
      </NuxtLink>
      <NuxtLink to="/register" class="px-5 py-2 rounded-xl border border-accent/60 hover:bg-accent/10">
        Registrarse
      </NuxtLink>
    </div>

    <div class="text-sm opacity-70">
      ¿Necesitas ayuda? <a href="#" class="text-accent hover:underline">Ver documentación</a>
    </div>
  </section>
</template>
