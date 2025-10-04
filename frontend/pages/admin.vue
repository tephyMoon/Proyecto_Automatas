<script setup lang="ts">
definePageMeta({
  layout: 'default',
  middleware: ['require-admin']
})
</script>

<template>
  <section class="space-y-4">
    <h2 class="text-2xl font-semibold">Panel de administración</h2>
    <div class="p-4 rounded-2xl border border-primary bg-primary/20">
      <p class="text-sm opacity-80">Gestión de usuarios, roles y parametrización (pendiente de backend).</p>
    </div>
  </section>
</template>
