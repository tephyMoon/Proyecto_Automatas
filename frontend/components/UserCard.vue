<script setup lang="ts">
defineProps<{
  name: string
  role: 'analista' | 'admin' | 'supervisor'
  email?: string
}>()
</script>

<template>
  <div class="p-4 rounded-2xl border border-primary bg-primary/20">
    <div class="flex items-center gap-3">
      <div class="w-12 h-12 rounded-xl bg-accent/30" />
      <div>
        <p class="font-semibold leading-tight">{{ name }}</p>
        <p class="text-xs opacity-70 capitalize">{{ role }}</p>
        <p v-if="email" class="text-xs opacity-80">{{ email }}</p>
      </div>
    </div>
  </div>
</template>
