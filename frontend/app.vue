<script setup lang="ts">
// Forzamos el modo oscuro agregando la clase 'dark' al <html> al montar la app
onMounted(() => {
  if (typeof document !== 'undefined') {
    document.documentElement.classList.add('dark')
  }
})
</script>

<template>
  <NuxtLayout>
    <NuxtPage />
  </NuxtLayout>
</template>
