<template>
  <div class="min-h-screen bg-background text-text">
    <Navbar />
    <main class="max-w-7xl mx-auto px-4 py-6">
      <slot />
    </main>
    <Footer />
  </div>
</template>

<script setup lang="ts">
import Navbar from '@/components/Navbar.vue'
import Footer from '@/components/Footer.vue'
</script>
