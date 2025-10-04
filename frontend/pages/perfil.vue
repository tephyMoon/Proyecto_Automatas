<script setup lang="ts">
definePageMeta({
  layout: 'default',
  middleware: ['require-auth']
})
</script>

<template>
  <section class="space-y-4">
    <h2 class="text-2xl font-semibold">Gestión de perfil</h2>
    <div class="grid md:grid-cols-2 gap-4">
      <div class="p-4 rounded-2xl border border-primary bg-primary/20">
        <h3 class="font-semibold mb-2">Datos personales</h3>
        <div class="text-sm opacity-80">Formulario maquetado pendiente de integración.</div>
      </div>
      <div class="p-4 rounded-2xl border border-primary bg-primary/20">
        <h3 class="font-semibold mb-2">Fotografía</h3>
        <input type="file" accept="image/*" class="w-full px-3 py-2 rounded-lg bg-primary/50 border border-primary" />
      </div>
    </div>
  </section>
</template>
