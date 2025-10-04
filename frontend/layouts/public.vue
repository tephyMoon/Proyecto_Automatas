<template>
  <div class="min-h-screen bg-background text-text flex flex-col">
    <main class="flex-1 flex items-center justify-center p-6">
      <slot />
    </main>
    <Footer />
  </div>
</template>

<script setup lang="ts">
import Footer from '@/components/Footer.vue'
</script>
